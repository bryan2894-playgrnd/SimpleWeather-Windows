﻿#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

namespace SimpleWeather.UWP.Utf8JsonGen.Resolvers
{
    using System;
    using Utf8Json;

    public class GeneratedResolver : global::Utf8Json.IJsonFormatterResolver
    {
        public static readonly global::Utf8Json.IJsonFormatterResolver Instance = new GeneratedResolver();

        GeneratedResolver()
        {

        }

        public global::Utf8Json.IJsonFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::Utf8Json.IJsonFormatter<T> formatter;

            static FormatterCache()
            {
                var f = GeneratedResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::Utf8Json.IJsonFormatter<T>)f;
                }
            }
        }
    }

    internal static class GeneratedResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static GeneratedResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(9)
            {
                {typeof(global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>), 0 },
                {typeof(global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.Infrared>), 1 },
                {typeof(global::SimpleWeather.UWP.WNS.FirebaseUWPUser), 2 },
                {typeof(global::SimpleWeather.UWP.WNS.WNSChannel), 3 },
                {typeof(global::SimpleWeather.UWP.Radar.RainViewer.RadarItem), 4 },
                {typeof(global::SimpleWeather.UWP.Radar.RainViewer.Radar), 5 },
                {typeof(global::SimpleWeather.UWP.Radar.RainViewer.Infrared), 6 },
                {typeof(global::SimpleWeather.UWP.Radar.RainViewer.Satellite), 7 },
                {typeof(global::SimpleWeather.UWP.Radar.RainViewer.Rootobject), 8 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key)) return null;

            switch (key)
            {
                case 0: return new global::Utf8Json.Formatters.ListFormatter<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>();
                case 1: return new global::Utf8Json.Formatters.ListFormatter<global::SimpleWeather.UWP.Radar.RainViewer.Infrared>();
                case 2: return new SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.WNS.FirebaseUWPUserFormatter();
                case 3: return new SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.WNS.WNSChannelFormatter();
                case 4: return new SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.Radar.RainViewer.RadarItemFormatter();
                case 5: return new SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.Radar.RainViewer.RadarFormatter();
                case 6: return new SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.Radar.RainViewer.InfraredFormatter();
                case 7: return new SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.Radar.RainViewer.SatelliteFormatter();
                case 8: return new SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.Radar.RainViewer.RootobjectFormatter();
                default: return null;
            }
        }
    }
}

#pragma warning disable 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.WNS
{
    using System;
    using Utf8Json;


    internal sealed class FirebaseUWPUserFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.UWP.WNS.FirebaseUWPUser>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public FirebaseUWPUserFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("channel_uri"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("expiration_time"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("package_name"), 2},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("channel_uri"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("expiration_time"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("package_name"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.UWP.WNS.FirebaseUWPUser value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.channel_uri);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt64(value.expiration_time);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.package_name);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.UWP.WNS.FirebaseUWPUser Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __channel_uri__ = default(string);
            var __channel_uri__b__ = false;
            var __expiration_time__ = default(long);
            var __expiration_time__b__ = false;
            var __package_name__ = default(string);
            var __package_name__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __channel_uri__ = reader.ReadString();
                        __channel_uri__b__ = true;
                        break;
                    case 1:
                        __expiration_time__ = reader.ReadInt64();
                        __expiration_time__b__ = true;
                        break;
                    case 2:
                        __package_name__ = reader.ReadString();
                        __package_name__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.UWP.WNS.FirebaseUWPUser();
            if(__channel_uri__b__) ____result.channel_uri = __channel_uri__;
            if(__expiration_time__b__) ____result.expiration_time = __expiration_time__;
            if(__package_name__b__) ____result.package_name = __package_name__;

            return ____result;
        }
    }


    internal sealed class WNSChannelFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.UWP.WNS.WNSChannel>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public WNSChannelFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ChannelUri"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("ExpirationTime"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("ChannelUri"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("ExpirationTime"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.UWP.WNS.WNSChannel value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.ChannelUri);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Serialize(ref writer, value.ExpirationTime, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.UWP.WNS.WNSChannel Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __ChannelUri__ = default(string);
            var __ChannelUri__b__ = false;
            var __ExpirationTime__ = default(global::System.DateTimeOffset);
            var __ExpirationTime__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __ChannelUri__ = reader.ReadString();
                        __ChannelUri__b__ = true;
                        break;
                    case 1:
                        __ExpirationTime__ = formatterResolver.GetFormatterWithVerify<global::System.DateTimeOffset>().Deserialize(ref reader, formatterResolver);
                        __ExpirationTime__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.UWP.WNS.WNSChannel();
            if(__ChannelUri__b__) ____result.ChannelUri = __ChannelUri__;
            if(__ExpirationTime__b__) ____result.ExpirationTime = __ExpirationTime__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace SimpleWeather.UWP.Utf8JsonGen.Formatters.SimpleWeather.UWP.Radar.RainViewer
{
    using System;
    using Utf8Json;


    public sealed class RadarItemFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RadarItemFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("time"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("path"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("time"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("path"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.UWP.Radar.RainViewer.RadarItem value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.time);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.path);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.UWP.Radar.RainViewer.RadarItem Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __time__ = default(int);
            var __time__b__ = false;
            var __path__ = default(string);
            var __path__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __time__ = reader.ReadInt32();
                        __time__b__ = true;
                        break;
                    case 1:
                        __path__ = reader.ReadString();
                        __path__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.UWP.Radar.RainViewer.RadarItem();
            if(__time__b__) ____result.time = __time__;
            if(__path__b__) ____result.path = __path__;

            return ____result;
        }
    }


    public sealed class RadarFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.UWP.Radar.RainViewer.Radar>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RadarFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("past"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("nowcast"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("past"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("nowcast"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.UWP.Radar.RainViewer.Radar value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>>().Serialize(ref writer, value.past, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[1]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>>().Serialize(ref writer, value.nowcast, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.UWP.Radar.RainViewer.Radar Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __past__ = default(global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>);
            var __past__b__ = false;
            var __nowcast__ = default(global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>);
            var __nowcast__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __past__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>>().Deserialize(ref reader, formatterResolver);
                        __past__b__ = true;
                        break;
                    case 1:
                        __nowcast__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.RadarItem>>().Deserialize(ref reader, formatterResolver);
                        __nowcast__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.UWP.Radar.RainViewer.Radar();
            if(__past__b__) ____result.past = __past__;
            if(__nowcast__b__) ____result.nowcast = __nowcast__;

            return ____result;
        }
    }


    public sealed class InfraredFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.UWP.Radar.RainViewer.Infrared>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public InfraredFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("time"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("path"), 1},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("time"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("path"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.UWP.Radar.RainViewer.Infrared value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteInt32(value.time);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteString(value.path);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.UWP.Radar.RainViewer.Infrared Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __time__ = default(int);
            var __time__b__ = false;
            var __path__ = default(string);
            var __path__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __time__ = reader.ReadInt32();
                        __time__b__ = true;
                        break;
                    case 1:
                        __path__ = reader.ReadString();
                        __path__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.UWP.Radar.RainViewer.Infrared();
            if(__time__b__) ____result.time = __time__;
            if(__path__b__) ____result.path = __path__;

            return ____result;
        }
    }


    public sealed class SatelliteFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.UWP.Radar.RainViewer.Satellite>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public SatelliteFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("infrared"), 0},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("infrared"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.UWP.Radar.RainViewer.Satellite value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.Infrared>>().Serialize(ref writer, value.infrared, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.UWP.Radar.RainViewer.Satellite Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __infrared__ = default(global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.Infrared>);
            var __infrared__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __infrared__ = formatterResolver.GetFormatterWithVerify<global::System.Collections.Generic.List<global::SimpleWeather.UWP.Radar.RainViewer.Infrared>>().Deserialize(ref reader, formatterResolver);
                        __infrared__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.UWP.Radar.RainViewer.Satellite();
            if(__infrared__b__) ____result.infrared = __infrared__;

            return ____result;
        }
    }


    public sealed class RootobjectFormatter : global::Utf8Json.IJsonFormatter<global::SimpleWeather.UWP.Radar.RainViewer.Rootobject>
    {
        readonly global::Utf8Json.Internal.AutomataDictionary ____keyMapping;
        readonly byte[][] ____stringByteKeys;

        public RootobjectFormatter()
        {
            this.____keyMapping = new global::Utf8Json.Internal.AutomataDictionary()
            {
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("version"), 0},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("generated"), 1},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("host"), 2},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("radar"), 3},
                { JsonWriter.GetEncodedPropertyNameWithoutQuotation("satellite"), 4},
            };

            this.____stringByteKeys = new byte[][]
            {
                JsonWriter.GetEncodedPropertyNameWithBeginObject("version"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("generated"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("host"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("radar"),
                JsonWriter.GetEncodedPropertyNameWithPrefixValueSeparator("satellite"),
                
            };
        }

        public void Serialize(ref JsonWriter writer, global::SimpleWeather.UWP.Radar.RainViewer.Rootobject value, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (value == null)
            {
                writer.WriteNull();
                return;
            }
            

            writer.WriteRaw(this.____stringByteKeys[0]);
            writer.WriteString(value.version);
            writer.WriteRaw(this.____stringByteKeys[1]);
            writer.WriteInt32(value.generated);
            writer.WriteRaw(this.____stringByteKeys[2]);
            writer.WriteString(value.host);
            writer.WriteRaw(this.____stringByteKeys[3]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.UWP.Radar.RainViewer.Radar>().Serialize(ref writer, value.radar, formatterResolver);
            writer.WriteRaw(this.____stringByteKeys[4]);
            formatterResolver.GetFormatterWithVerify<global::SimpleWeather.UWP.Radar.RainViewer.Satellite>().Serialize(ref writer, value.satellite, formatterResolver);
            
            writer.WriteEndObject();
        }

        public global::SimpleWeather.UWP.Radar.RainViewer.Rootobject Deserialize(ref JsonReader reader, global::Utf8Json.IJsonFormatterResolver formatterResolver)
        {
            if (reader.ReadIsNull())
            {
                return null;
            }
            

            var __version__ = default(string);
            var __version__b__ = false;
            var __generated__ = default(int);
            var __generated__b__ = false;
            var __host__ = default(string);
            var __host__b__ = false;
            var __radar__ = default(global::SimpleWeather.UWP.Radar.RainViewer.Radar);
            var __radar__b__ = false;
            var __satellite__ = default(global::SimpleWeather.UWP.Radar.RainViewer.Satellite);
            var __satellite__b__ = false;

            var ____count = 0;
            reader.ReadIsBeginObjectWithVerify();
            while (!reader.ReadIsEndObjectWithSkipValueSeparator(ref ____count))
            {
                var stringKey = reader.ReadPropertyNameSegmentRaw();
                int key;
                if (!____keyMapping.TryGetValueSafe(stringKey, out key))
                {
                    reader.ReadNextBlock();
                    goto NEXT_LOOP;
                }

                switch (key)
                {
                    case 0:
                        __version__ = reader.ReadString();
                        __version__b__ = true;
                        break;
                    case 1:
                        __generated__ = reader.ReadInt32();
                        __generated__b__ = true;
                        break;
                    case 2:
                        __host__ = reader.ReadString();
                        __host__b__ = true;
                        break;
                    case 3:
                        __radar__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.UWP.Radar.RainViewer.Radar>().Deserialize(ref reader, formatterResolver);
                        __radar__b__ = true;
                        break;
                    case 4:
                        __satellite__ = formatterResolver.GetFormatterWithVerify<global::SimpleWeather.UWP.Radar.RainViewer.Satellite>().Deserialize(ref reader, formatterResolver);
                        __satellite__b__ = true;
                        break;
                    default:
                        reader.ReadNextBlock();
                        break;
                }

                NEXT_LOOP:
                continue;
            }

            var ____result = new global::SimpleWeather.UWP.Radar.RainViewer.Rootobject();
            if(__version__b__) ____result.version = __version__;
            if(__generated__b__) ____result.generated = __generated__;
            if(__host__b__) ____result.host = __host__;
            if(__radar__b__) ____result.radar = __radar__;
            if(__satellite__b__) ____result.satellite = __satellite__;

            return ____result;
        }
    }

}

#pragma warning disable 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
